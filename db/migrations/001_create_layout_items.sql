-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, owner, rank, count) VALUES (42.31, 'standard', 'blue', 98, 70);
INSERT INTO layout_items (weight, region, owner, rank, count) VALUES (73.81, 'open', 'legacy', 27, 59);
