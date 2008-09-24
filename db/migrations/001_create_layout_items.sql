-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, ratio, state, active) VALUES ('local', 71.5, 'cached', 80);
INSERT INTO layout_items (token, ratio, state, active) VALUES ('strict', 91.88, 'edge', 18);
INSERT INTO layout_items (token, ratio, state, active) VALUES ('local', 75.47, 'strict', 29);
