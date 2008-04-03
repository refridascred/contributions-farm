-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, owner, token, region, label) VALUES ('legacy', 'fallback', 'open', 'green', 'eu-west');
INSERT INTO layout_items (state, owner, token, region, label) VALUES ('eu-west', 'eu-west', 'strict', 'fallback', 'blue');
INSERT INTO layout_items (state, owner, token, region, label) VALUES ('edge', 'stable', 'local', 'cached', 'fallback');
