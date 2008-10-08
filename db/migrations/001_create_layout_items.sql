-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, rank, region, weight) VALUES (24.88, 95, 'legacy', 21.95);
INSERT INTO layout_items (score, rank, region, weight) VALUES (0.67, 45, 'local', 32.16);
