-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, level, state, weight) VALUES (14, 26, 'open', 64.2);
INSERT INTO layout_items (count, level, state, weight) VALUES (27, 15, 'eu-west', 96.1);
INSERT INTO layout_items (count, level, state, weight) VALUES (98, 82, 'legacy', 19.16);
