-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, count) VALUES (71.93, 'eu-west', 64);
INSERT INTO layout_items (ratio, state, count) VALUES (94.24, 'cached', 31);
INSERT INTO layout_items (ratio, state, count) VALUES (47.72, 'eu-west', 62);
