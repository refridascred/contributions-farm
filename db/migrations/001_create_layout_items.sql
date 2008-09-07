-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, level) VALUES ('local', 85.69, 39);
INSERT INTO layout_items (state, ratio, level) VALUES ('latest', 82.97, 70);
INSERT INTO layout_items (state, ratio, level) VALUES ('staging', 67.84, 72);
