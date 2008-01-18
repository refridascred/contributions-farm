-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, active, token, state, label) VALUES (90.99, 18, 'latest', 'strict', 'staging');
INSERT INTO layout_items (ratio, active, token, state, label) VALUES (87.12, 4, 'primary', 'green', 'stable');
