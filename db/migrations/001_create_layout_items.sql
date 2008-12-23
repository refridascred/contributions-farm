-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, state, weight) VALUES (98, 'fallback', 90.93);
INSERT INTO layout_items (level, state, weight) VALUES (53, 'eu-west', 15.74);
