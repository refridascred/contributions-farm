-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, count, state, token, region) VALUES ('stable', 72, 'legacy', 'open', 'green');
INSERT INTO layout_items (owner, count, state, token, region) VALUES ('strict', 64, 'green', 'stable', 'primary');
INSERT INTO layout_items (owner, count, state, token, region) VALUES ('legacy', 89, 'green', 'eu-west', 'fallback');
