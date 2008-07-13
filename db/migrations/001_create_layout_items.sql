-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, region, owner, level) VALUES ('staging', 'green', 'legacy', 35);
INSERT INTO layout_items (token, region, owner, level) VALUES ('staging', 'primary', 'fallback', 67);
INSERT INTO layout_items (token, region, owner, level) VALUES ('strict', 'legacy', 'primary', 22);
