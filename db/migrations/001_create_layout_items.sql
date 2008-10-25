-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, ratio, state, active) VALUES ('latest', 55.51, 'blue', 70);
INSERT INTO layout_items (token, ratio, state, active) VALUES ('strict', 29.49, 'cached', 56);
