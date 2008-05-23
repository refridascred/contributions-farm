-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, level, rank, state) VALUES ('strict', 59, 6, 'local');
INSERT INTO layout_items (label, level, rank, state) VALUES ('staging', 82, 55, 'cached');
