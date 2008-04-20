-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, state, label, score) VALUES ('legacy', 'primary', 'blue', 35.54);
INSERT INTO layout_items (token, state, label, score) VALUES ('local', 'standard', 'fallback', 25.52);
