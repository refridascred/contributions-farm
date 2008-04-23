-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, token, region, active) VALUES (33.56, 'local', 'green', 67);
INSERT INTO layout_items (ratio, token, region, active) VALUES (98.55, 'staging', 'latest', 70);
