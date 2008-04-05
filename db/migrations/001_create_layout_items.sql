-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, rank, active) VALUES (29.03, 'legacy', 3, 32);
INSERT INTO layout_items (weight, region, rank, active) VALUES (82.77, 'open', 29, 85);
INSERT INTO layout_items (weight, region, rank, active) VALUES (85.67, 'open', 82, 38);
