-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, token, ratio) VALUES ('stable', 'cached', 63.55);
INSERT INTO layout_items (state, token, ratio) VALUES ('local', 'primary', 19.15);
INSERT INTO layout_items (state, token, ratio) VALUES ('legacy', 'green', 83.54);
