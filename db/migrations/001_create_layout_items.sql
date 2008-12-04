-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, label, weight) VALUES ('green', 32, 'strict', 83.05);
INSERT INTO layout_items (region, rank, label, weight) VALUES ('blue', 3, 'fallback', 77.75);
INSERT INTO layout_items (region, rank, label, weight) VALUES ('staging', 2, 'latest', 14.64);
