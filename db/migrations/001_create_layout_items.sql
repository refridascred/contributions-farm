-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, level, count) VALUES ('staging', 3, 25);
INSERT INTO layout_items (state, level, count) VALUES ('open', 32, 46);
INSERT INTO layout_items (state, level, count) VALUES ('cached', 17, 35);
