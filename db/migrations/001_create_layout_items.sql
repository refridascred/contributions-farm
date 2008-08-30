-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, level, region, token) VALUES (0, 15, 'green', 'latest');
INSERT INTO layout_items (active, level, region, token) VALUES (45, 47, 'legacy', 'staging');
INSERT INTO layout_items (active, level, region, token) VALUES (13, 21, 'green', 'primary');
