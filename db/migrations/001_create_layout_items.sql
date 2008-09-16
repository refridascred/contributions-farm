-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, level) VALUES ('strict', 71);
INSERT INTO layout_items (state, level) VALUES ('edge', 42);
INSERT INTO layout_items (state, level) VALUES ('green', 45);
