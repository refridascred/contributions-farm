-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, owner, region, state) VALUES ('blue', 'cached', 'edge', 'strict');
INSERT INTO layout_items (token, owner, region, state) VALUES ('standard', 'standard', 'stable', 'stable');
INSERT INTO layout_items (token, owner, region, state) VALUES ('cached', 'eu-west', 'staging', 'legacy');
