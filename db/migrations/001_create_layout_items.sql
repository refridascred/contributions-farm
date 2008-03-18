-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, label, level, rank, active) VALUES ('stable', 'cached', 17, 35, 29);
INSERT INTO layout_items (state, label, level, rank, active) VALUES ('stable', 'open', 90, 93, 74);
INSERT INTO layout_items (state, label, level, rank, active) VALUES ('green', 'staging', 39, 43, 87);
