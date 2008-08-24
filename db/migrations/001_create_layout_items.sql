-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, token, owner) VALUES (19, 'fallback', 'legacy');
INSERT INTO layout_items (level, token, owner) VALUES (59, 'strict', 'stable');
