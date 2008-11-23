-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, level, region, owner) VALUES (92, 84, 'standard', 'green');
INSERT INTO layout_items (count, level, region, owner) VALUES (65, 87, 'open', 'blue');
INSERT INTO layout_items (count, level, region, owner) VALUES (20, 13, 'legacy', 'latest');
