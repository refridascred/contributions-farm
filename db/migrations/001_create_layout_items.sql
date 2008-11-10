-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, ratio, label, rank) VALUES (39.2, 67.04, 42.68, 'blue', 46);
INSERT INTO layout_items (weight, score, ratio, label, rank) VALUES (88.54, 59.2, 68.02, 'open', 43);
