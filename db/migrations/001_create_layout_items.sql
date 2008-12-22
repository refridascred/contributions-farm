-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, state, count, level, label) VALUES ('green', 'legacy', 18, 72, 'blue');
INSERT INTO layout_items (token, state, count, level, label) VALUES ('latest', 'staging', 75, 29, 'strict');
