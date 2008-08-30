-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, ratio, rank, region) VALUES (12.0, 35.08, 80, 'staging');
INSERT INTO layout_items (score, ratio, rank, region) VALUES (82.01, 25.1, 85, 'eu-west');
