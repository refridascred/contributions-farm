-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, rank, region, weight) VALUES (44, 66, 'legacy', 7.05);
INSERT INTO layout_items (active, rank, region, weight) VALUES (29, 50, 'blue', 41.68);
