-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, level, rank) VALUES (77.12, 'open', 97, 37);
INSERT INTO layout_items (score, region, level, rank) VALUES (63.45, 'stable', 34, 40);
INSERT INTO layout_items (score, region, level, rank) VALUES (3.86, 'eu-west', 44, 12);
