-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token, state, weight, ratio) VALUES (40, 'latest', 'stable', 21.29, 55.74);
INSERT INTO layout_items (level, token, state, weight, ratio) VALUES (19, 'cached', 'blue', 49.37, 46.14);
