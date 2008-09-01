-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, level, state) VALUES ('cached', 36, 'local');
INSERT INTO layout_items (token, level, state) VALUES ('fallback', 77, 'open');
INSERT INTO layout_items (token, level, state) VALUES ('strict', 79, 'local');
