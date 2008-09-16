-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, level, label, token) VALUES ('latest', 'blue', 91, 'fallback', 'blue');
INSERT INTO layout_items (owner, state, level, label, token) VALUES ('blue', 'green', 55, 'open', 'stable');
