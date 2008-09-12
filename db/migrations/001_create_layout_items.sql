-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, weight, level, active) VALUES ('blue', 80.25, 77, 64);
INSERT INTO layout_items (state, weight, level, active) VALUES ('strict', 15.54, 73, 14);
INSERT INTO layout_items (state, weight, level, active) VALUES ('staging', 81.24, 2, 33);
