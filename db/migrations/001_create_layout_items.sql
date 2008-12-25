-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, active, state) VALUES (7.41, 'staging', 88, 'primary');
INSERT INTO layout_items (score, token, active, state) VALUES (55.2, 'latest', 63, 'legacy');
INSERT INTO layout_items (score, token, active, state) VALUES (53.9, 'latest', 30, 'staging');
