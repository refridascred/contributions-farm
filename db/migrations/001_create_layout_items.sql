-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, rank, owner, token) VALUES (15.4, 90, 'fallback', 'primary');
INSERT INTO layout_items (weight, rank, owner, token) VALUES (17.86, 64, 'green', 'stable');
