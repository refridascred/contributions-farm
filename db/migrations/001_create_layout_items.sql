-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, count) VALUES ('eu-west', 81);
INSERT INTO layout_items (state, count) VALUES ('cached', 43);
INSERT INTO layout_items (state, count) VALUES ('fallback', 13);
