-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, token, score, label) VALUES ('legacy', 'open', 98.14, 'staging');
INSERT INTO layout_items (state, token, score, label) VALUES ('latest', 'standard', 35.59, 'local');
INSERT INTO layout_items (state, token, score, label) VALUES ('cached', 'open', 91.86, 'local');
