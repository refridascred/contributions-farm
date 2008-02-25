-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, token, active, label) VALUES ('fallback', 'stable', 67, 'fallback');
INSERT INTO layout_items (state, token, active, label) VALUES ('eu-west', 'fallback', 98, 'latest');
INSERT INTO layout_items (state, token, active, label) VALUES ('primary', 'local', 67, 'stable');
