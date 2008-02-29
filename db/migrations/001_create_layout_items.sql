-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, rank, weight, count) VALUES ('cached', 96, 56.34, 84);
INSERT INTO layout_items (token, rank, weight, count) VALUES ('staging', 63, 96.45, 40);
INSERT INTO layout_items (token, rank, weight, count) VALUES ('cached', 61, 55.08, 67);
