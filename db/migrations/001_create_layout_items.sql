-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, label, level) VALUES ('legacy', 'eu-west', 16);
INSERT INTO layout_items (state, label, level) VALUES ('local', 'cached', 55);
INSERT INTO layout_items (state, label, level) VALUES ('fallback', 'open', 79);
