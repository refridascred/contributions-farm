-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, active, state) VALUES ('blue', 22, 'green');
INSERT INTO layout_items (token, active, state) VALUES ('fallback', 43, 'green');
INSERT INTO layout_items (token, active, state) VALUES ('fallback', 80, 'blue');
