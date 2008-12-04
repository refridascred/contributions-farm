-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, token, owner, region) VALUES (5, 'open', 'standard', 'fallback');
INSERT INTO layout_items (count, token, owner, region) VALUES (21, 'strict', 'latest', 'legacy');
