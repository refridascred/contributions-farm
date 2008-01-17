-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, owner, level, count, token) VALUES ('blue', 'cached', 59, 3, 'open');
INSERT INTO layout_items (region, owner, level, count, token) VALUES ('legacy', 'open', 16, 30, 'fallback');
