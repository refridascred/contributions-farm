-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, token, owner, region) VALUES (28, 'latest', 'cached', 'fallback');
INSERT INTO layout_items (level, token, owner, region) VALUES (18, 'green', 'standard', 'primary');
