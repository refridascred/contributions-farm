-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, state, ratio) VALUES ('standard', 'eu-west', 5.03);
INSERT INTO layout_items (token, state, ratio) VALUES ('blue', 'local', 75.84);
INSERT INTO layout_items (token, state, ratio) VALUES ('fallback', 'legacy', 51.45);
