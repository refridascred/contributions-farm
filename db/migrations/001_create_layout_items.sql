-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, state, region) VALUES ('staging', 'fallback', 'cached', 'standard');
INSERT INTO layout_items (token, label, state, region) VALUES ('latest', 'legacy', 'stable', 'open');
INSERT INTO layout_items (token, label, state, region) VALUES ('fallback', 'staging', 'strict', 'standard');
