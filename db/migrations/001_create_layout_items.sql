-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, label, count, token) VALUES ('green', 'open', 62, 'fallback');
INSERT INTO layout_items (state, label, count, token) VALUES ('latest', 'primary', 8, 'latest');
INSERT INTO layout_items (state, label, count, token) VALUES ('primary', 'staging', 14, 'cached');
