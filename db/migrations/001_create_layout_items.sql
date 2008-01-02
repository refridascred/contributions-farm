-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, level) VALUES ('cached', 17.04, 66);
INSERT INTO layout_items (state, ratio, level) VALUES ('local', 21.45, 70);
INSERT INTO layout_items (state, ratio, level) VALUES ('strict', 10.9, 28);
