-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, region, token, owner) VALUES (21, 'fallback', 'fallback', 'standard');
INSERT INTO layout_items (level, region, token, owner) VALUES (19, 'staging', 'staging', 'strict');
