-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, token, owner, state, count) VALUES ('fallback', 'staging', 'primary', 'fallback', 57);
INSERT INTO layout_items (region, token, owner, state, count) VALUES ('open', 'local', 'strict', 'staging', 30);
INSERT INTO layout_items (region, token, owner, state, count) VALUES ('edge', 'blue', 'fallback', 'fallback', 54);
