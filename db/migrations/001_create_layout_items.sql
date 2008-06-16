-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, level) VALUES ('open', 43);
INSERT INTO layout_items (state, level) VALUES ('cached', 97);
INSERT INTO layout_items (state, level) VALUES ('local', 33);
