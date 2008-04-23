-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, region, weight, owner, ratio) VALUES (70, 'local', 26.16, 'latest', 12.76);
INSERT INTO layout_items (rank, region, weight, owner, ratio) VALUES (89, 'primary', 14.49, 'fallback', 33.13);
INSERT INTO layout_items (rank, region, weight, owner, ratio) VALUES (94, 'open', 18.72, 'blue', 58.02);
