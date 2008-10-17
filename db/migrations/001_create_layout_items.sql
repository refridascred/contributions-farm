-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, level, region, state, token) VALUES (55, 73, 'legacy', 'standard', 'latest');
INSERT INTO layout_items (count, level, region, state, token) VALUES (59, 28, 'cached', 'legacy', 'fallback');
