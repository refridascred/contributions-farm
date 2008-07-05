-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, region, token) VALUES ('fallback', 'edge', 'strict');
INSERT INTO layout_items (owner, region, token) VALUES ('blue', 'fallback', 'fallback');
