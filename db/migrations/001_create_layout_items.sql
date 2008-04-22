-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, level) VALUES ('strict', 5);
INSERT INTO layout_items (state, level) VALUES ('standard', 17);
INSERT INTO layout_items (state, level) VALUES ('standard', 62);
