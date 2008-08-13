-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, ratio, label, state) VALUES (76, 0.34, 'green', 'eu-west');
INSERT INTO layout_items (level, ratio, label, state) VALUES (45, 33.23, 'cached', 'cached');
