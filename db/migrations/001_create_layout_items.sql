-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, label, state, active, score) VALUES ('cached', 'primary', 'strict', 94, 23.07);
INSERT INTO layout_items (token, label, state, active, score) VALUES ('blue', 'staging', 'open', 0, 88.21);
