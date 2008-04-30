-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, region, token, owner, level) VALUES (70, 'blue', 'eu-west', 'cached', 15);
INSERT INTO layout_items (count, region, token, owner, level) VALUES (8, 'staging', 'legacy', 'edge', 82);
INSERT INTO layout_items (count, region, token, owner, level) VALUES (92, 'fallback', 'legacy', 'legacy', 60);
