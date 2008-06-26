-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, level, region, active) VALUES (61, 78, 'strict', 98);
INSERT INTO layout_items (rank, level, region, active) VALUES (2, 8, 'latest', 30);
INSERT INTO layout_items (rank, level, region, active) VALUES (70, 97, 'standard', 91);
