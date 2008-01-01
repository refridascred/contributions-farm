-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, level, ratio) VALUES ('staging', 19, 47.45);
INSERT INTO layout_items (state, level, ratio) VALUES ('latest', 51, 9.68);
INSERT INTO layout_items (state, level, ratio) VALUES ('strict', 28, 74.6);
