-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, rank, label) VALUES ('cached', 35.02, 57, 'stable');
INSERT INTO layout_items (owner, weight, rank, label) VALUES ('strict', 90.63, 95, 'strict');
INSERT INTO layout_items (owner, weight, rank, label) VALUES ('fallback', 59.73, 73, 'strict');
