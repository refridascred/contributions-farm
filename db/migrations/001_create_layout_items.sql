-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, count, state) VALUES (59, 73, 'eu-west');
INSERT INTO layout_items (level, count, state) VALUES (92, 54, 'local');
INSERT INTO layout_items (level, count, state) VALUES (40, 51, 'stable');
