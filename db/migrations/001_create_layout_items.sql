-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, active, token, state, owner) VALUES (61.41, 85, 'staging', 'edge', 'edge');
INSERT INTO layout_items (ratio, active, token, state, owner) VALUES (34.92, 96, 'staging', 'local', 'open');
INSERT INTO layout_items (ratio, active, token, state, owner) VALUES (40.5, 8, 'standard', 'strict', 'open');
